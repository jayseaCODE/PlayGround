using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MainClient : MonoBehaviour {

    public Spawner spawner;

    private bool doesPlayerHaveAnEntity;
    private MonoBehaviour playerEntity;
    private MonoBehaviour entity;
    private int incrementorDrone = 0;
    private int incrementorSniper = 0;
    private int incrementorMedic = 0;

    #region Camera
    private Camera activeCamera;
    private List<Camera> cameras;
    private Vector3 cameraOffSet = new Vector3(0, 1, -2);
    #endregion

    #region Player Character Control
    private CharacterController characterController;
    private float speed = 6.0f;
    private float jumpSpeed = 8.0f;
    private float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    #endregion

    #region Commander
    private bool UseCommander;
    private Commander commander;
    private Drone DroneCloneSource;
    #endregion

    public void Start()
    {
        cameras = new List<Camera>(Camera.allCameras);
        activeCamera = Camera.main;
        foreach (Camera camera in cameras)
        {
            camera.enabled = false;
        }
        activeCamera.enabled = true;

        commander = new Commander();
    }

    public void Update()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(5, 20), Random.Range(-10, 10));

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            UseCommander = !UseCommander;
            Debug.Log($"Use Commander: {UseCommander.ToString()}");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (UseCommander)
            {
                commander.SetUnitCommand(new CreateUnitCommand(new Drone()));
            }
            else
            {
                entity = spawner.SpawnEnemy(EnemyType.Drone);
                AttachCharacterController(entity);

                entity.name = "Drone_Clone_" + ++incrementorDrone;
                entity.transform.SetPositionAndRotation(randomPosition, new Quaternion());
                //enemy.transform.position.Set(Random.Range(0, 20), Random.Range(0, 20), Random.Range(0, 20));
                (entity as IEnemy).Kill();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            entity = spawner.SpawnEnemy(EnemyType.Sniper);
            AttachCharacterController(entity);

            entity.name = "Sniper_Clone_" + ++incrementorSniper;
            entity.transform.SetPositionAndRotation(randomPosition, new Quaternion());
            (entity as IEnemy).Kill();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            entity = spawner.SpawnAlly(AllyType.Medic);
            AttachCharacterController(entity);

            entity.name = "Medic_Clone_" + ++incrementorMedic;
            entity.transform.SetPositionAndRotation(randomPosition, new Quaternion());
            (entity as IAlly).Rescue();
        }

        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            ToggleToNextCamera();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            commander.ExecuteAllUnitCommands();
        }

        if (!object.Equals(characterController, null))
        {
            if (characterController.isGrounded)
            {
                // We are grounded, so recalculate
                // move direction directly from axes

                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                moveDirection *= speed;

                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                }
            }

            // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
            // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
            // as an acceleration (ms^-2)
            moveDirection.y -= gravity * Time.deltaTime;

            // Move the controller
            characterController.Move(moveDirection * Time.deltaTime);
        }
    }

    private void LateUpdate()
    {
        if (!object.Equals(playerEntity, null))
        {
            Camera mainCamera = Camera.main;
            mainCamera.transform.position = playerEntity.transform.position + cameraOffSet;
        }
    }

    private void ToggleToNextCamera()
    {
        var prevCamera = activeCamera;
        var indexOfCurrentCamera = cameras.FindIndex(camera => camera.enabled == true);
        (cameras[indexOfCurrentCamera]).enabled = false;
        int indexOfNextCamera = (indexOfCurrentCamera + 1) % (cameras.Count);
        (cameras[indexOfNextCamera]).enabled = true;
    }
    private void AttachCharacterController(MonoBehaviour entity)
    {
        if (!doesPlayerHaveAnEntity)
        {
            characterController = entity.gameObject.AddComponent(typeof(CharacterController)) as CharacterController;
            playerEntity = entity;
            doesPlayerHaveAnEntity = true;
        }
    }
}
