using System;
using Unity.Behavior;

[BlackboardEnum]
public enum State
{
    Idle = 0,
    Patrol,
    Chase,
    Attack
}
