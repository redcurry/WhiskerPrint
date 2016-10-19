using System;

namespace WhiskerPrint.LogicLayer
{
    public interface IProgressible
    {
        event EventHandler Progress;

        int CountSteps();
    }
}
