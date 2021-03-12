using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Burst;

public class MoverSystem : ComponentSystem {
    
    [BurstCompile]
    protected override void OnUpdate() {

        Entities.ForEach((ref Translation translation, ref MoveSpeedComponent moveSpeedComponent) => {
            translation.Value.y += moveSpeedComponent.moveSpeed * Time.DeltaTime;

            if(translation.Value.y > 5f) {
                moveSpeedComponent.moveSpeed = -math.abs(moveSpeedComponent.moveSpeed);
            }

            if(translation.Value.y < -5f) {
                moveSpeedComponent.moveSpeed = +math.abs(moveSpeedComponent.moveSpeed);
            }
        });

    }
}
