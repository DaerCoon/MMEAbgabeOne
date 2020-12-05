using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class PlayerBehaviorSystem : SystemBase
{
   
    protected override void OnUpdate()
    {
        var deltaTime = Time.DeltaTime;
        float horizontalM = Input.GetAxis("Horizontal");
        float verticalM = Input.GetAxis("Vertical");

        float elapsedTime = (float)Time.ElapsedTime;
        Entities.ForEach((ref PlayerComponent player, ref Translation tran, ref Rotation rot) =>
        {
            player.RotationAngle += horizontalM * deltaTime;
            float3 direct = new float3(math.sin(player.RotationAngle), 0, math.cos(player.RotationAngle));
            rot.Value = quaternion.LookRotationSafe(direct, Vector3.up);
            tran.Value += direct * verticalM * player.Speed * elapsedTime* deltaTime;

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
