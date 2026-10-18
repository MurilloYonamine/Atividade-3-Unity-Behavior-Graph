using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "RangeDetector", story: "Update Range [Detector] and assign [Target]", category: "Action", id: "a2dcfc4d72b2c6085e66d956ea5c8388")]
public partial class RangeDetectorAction : Action
{
    [SerializeReference] public BlackboardVariable<RangeDetector> Detector;
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    
    protected override Status OnUpdate()
    {
        // Se for sucesso, o gráfico continuará para o próximo node
        // Se for falha, o inimigo irá patrulhar ou ficar em idle
        Target.Value = Detector.Value.UpdateDetector();
        return Target.Value == null ? Status.Failure : Status.Success;
    }
}

