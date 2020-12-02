using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class SpawnCollectableSystem : SystemBase
{
    BeginInitializationEntityCommandBufferSystem m_EntityCommandBufferSystem;

    protected override void OnCreate()
    {
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
    }

    protected override void OnUpdate()
    {
        var seed = (uint)UnityEngine.Random.Range(1, 99999);
        var random = new Unity.Mathematics.Random(seed);
        float y = 1f;
        var commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer().AsParallelWriter();
        Entities.WithBurst(FloatMode.Default, FloatPrecision.Standard, true)
                .ForEach((Entity entity, int entityInQueryIndex, in SpawnCollectableComponent spawnCollectableComponent)
            => {
                for (var i = 0; i < spawnCollectableComponent.AnzahlDerCollectables; i++)
                {
                    Entity entityInstance = commandBuffer.Instantiate(entityInQueryIndex, spawnCollectableComponent.CollectablePrefab);

                    float x = random.NextFloat(-5, 5);
                    float z = random.NextFloat(-5, 5);

                    float3 position = new float3(x, y, z);
                    commandBuffer.SetComponent(entityInQueryIndex, entityInstance, new Translation { Value = position });
                }
                commandBuffer.DestroyEntity(entityInQueryIndex, entity);
            }).ScheduleParallel();
        m_EntityCommandBufferSystem.AddJobHandleForProducer(Dependency);
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
