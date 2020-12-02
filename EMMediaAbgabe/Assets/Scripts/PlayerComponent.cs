using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct PlayerComponent : IComponentData
{
    public float Speed;
    public float RotationAngle;
}
