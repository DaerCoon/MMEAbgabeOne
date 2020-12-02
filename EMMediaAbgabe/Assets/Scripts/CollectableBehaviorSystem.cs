using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class CollectableBehaviorSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.WithAll<CollectedComponent, Rotation>().ForEach((ref Rotation rot) =>
        {
            
            float rotationDegres = 30.0f;
            rot.Value = math.mul(rot.Value, quaternion.RotateY(math.radians(deltaTime * rotationDegres)));
        }).Schedule();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
