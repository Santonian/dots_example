using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;

public class Spawner : ComponentSystem {


    protected override void OnStartRunning() {

        /*
        Entities.ForEach((ref PrefabEntityComponent prefabEntityComponent) => {

            NativeArray<Entity> entityArray = new NativeArray<Entity>(10000, Allocator.Temp);

            EntityManager.Instantiate(prefabEntityComponent.prefabEntity, entityArray);

            foreach(Entity e in entityArray) {
                EntityManager.AddComponent(e, typeof(LevelComponent));
                EntityManager.AddComponent(e, typeof(MoveSpeedComponent));

                EntityManager.SetComponentData(e, new LevelComponent { level = UnityEngine.Random.Range(10, 20) });
                EntityManager.SetComponentData(e, new MoveSpeedComponent { moveSpeed = UnityEngine.Random.Range(1f, 2f) });
                EntityManager.SetComponentData(e, new Translation { Value = new float3(UnityEngine.Random.Range(-8f, 8f), UnityEngine.Random.Range(-5f, 5f), 0) });
            }

            entityArray.Dispose();

        });
        */
        /*
        NativeArray<Entity> entityArray = new NativeArray<Entity>(100000, Allocator.Temp);

        EntityManager.Instantiate(PrefabEntities.prefabEntity, entityArray);

        foreach(Entity e in entityArray) {
            EntityManager.AddComponent(e, typeof(LevelComponent));
            EntityManager.AddComponent(e, typeof(MoveSpeedComponent));

            EntityManager.SetComponentData(e, new LevelComponent { level = UnityEngine.Random.Range(10, 20) });
            EntityManager.SetComponentData(e, new MoveSpeedComponent { moveSpeed = UnityEngine.Random.Range(1f, 2f) });
            EntityManager.SetComponentData(e, new Translation { Value = new float3(UnityEngine.Random.Range(-8f, 8f), UnityEngine.Random.Range(-5f, 5f), 0) });
        }

        entityArray.Dispose();
        */

    }

    protected override void OnUpdate() {
//        throw new System.NotImplementedException();
    }
}
