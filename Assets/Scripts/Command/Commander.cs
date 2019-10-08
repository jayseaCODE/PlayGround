using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander
{
    protected Queue<UnitCommand> unitCommandsToExecute;
    protected Queue<UnitCommand> unitCommandsExecuted;

    public Commander()
    {
        unitCommandsToExecute = new Queue<UnitCommand>();
        unitCommandsExecuted = new Queue<UnitCommand>();
    }

    public void SetUnitCommand(UnitCommand unitCommand)
    {
        unitCommandsToExecute.Enqueue(unitCommand);
    }

    public void ExecuteUnitCommand()
    {
        UnitCommand unitCommand = unitCommandsToExecute.Dequeue();
        unitCommand.Execute();
        unitCommandsExecuted.Enqueue(unitCommand);
    }

    public void ExecuteAllUnitCommands()
    {
        while (unitCommandsToExecute.Count > 0)
        {
            ExecuteUnitCommand();
        }
    }
}
