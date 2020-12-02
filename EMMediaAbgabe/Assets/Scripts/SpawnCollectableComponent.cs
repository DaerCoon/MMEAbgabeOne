using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct SpawnCollectableComponent : IComponentData
{
    public int AnzahlDerCollectables;
    public Entity CollectablePrefab;
}
