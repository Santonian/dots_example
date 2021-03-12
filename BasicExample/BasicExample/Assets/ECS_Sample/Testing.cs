using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

public class Testing : MonoBehaviour
{

    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;
    // Start is called before the first frame update
    void Start()
    {





    /*
     * 
     * Spawning Entities from scratch. Display sprite as rendermesh and material
     */

        

        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        EntityArchetype entityArchetype = entityManager.CreateArchetype(
                typeof(LevelComponent),
                typeof(Translation),
                typeof(RenderMesh),
                typeof(LocalToWorld),
                typeof(MoveSpeedComponent),
                typeof(RenderBounds)
            );

        NativeArray<Entity> entityArray = new NativeArray<Entity>(100000, Allocator.Temp);
        entityManager.CreateEntity(entityArchetype, entityArray);

        foreach(Entity e in entityArray) {
            entityManager.SetComponentData(e, new LevelComponent { level = UnityEngine.Random.Range(10, 20) });
            entityManager.SetComponentData(e, new MoveSpeedComponent { moveSpeed = UnityEngine.Random.Range(1f, 2f) });
            entityManager.SetComponentData(e, new Translation { Value = new float3(UnityEngine.Random.Range(-8f, 8f), UnityEngine.Random.Range(-5f, 5f), 0) });

            entityManager.SetSharedComponentData(e, new RenderMesh { mesh = this.mesh, material = this.material });
        }

        entityArray.Dispose();
        
    }
}
