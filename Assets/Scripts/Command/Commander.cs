using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander
{
    protected Stack<UnitCommand> unitCommandsToExecute;
    protected Stack<UnitCommand> unitCommandsExecuted;

    public void SetUnitCommand(UnitCommand unitCommand)
    {
        unitCommandsToExecute.Push(unitCommand);
    }

    public void ExecuteUnitCommand()
    {
        UnitCommand unitCommand = unitCommandsToExecute.Pop();
        unitCommand.Execute();
        unitCommandsExecuted.Push(unitCommand);
    }
}
