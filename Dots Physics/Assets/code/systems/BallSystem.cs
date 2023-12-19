using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Mathematics;

public partial struct BallSystem : ISystem
{
    InputComponent inputComponent;

    private void OnUpdate(ref SystemState state){
        EntityManager entityManager = state.EntityManager;

        if(!SystemAPI.TryGetSingleton(out inputComponent)){
            return;
        }

        NativeArray<Entity> entities = entityManager.GetAllEntities(Allocator.Temp);

        foreach(Entity entity in entities){
            if( entityManager.HasComponent<BallComponent>(entity)){
                BallComponent ball = entityManager.GetComponentData<BallComponent>(entity);

                RefRW<PhysicsVelocity> physicsVelocity = SystemAPI.GetComponentRW<PhysicsVelocity>(entity);

                physicsVelocity.ValueRW.Linear += new float3(inputComponent.movement.x * ball.moveSpeed * SystemAPI.Time.DeltaTime,
                0, inputComponent.movement.y * ball.moveSpeed * SystemAPI.Time.DeltaTime);
            }
        }
    }
}
