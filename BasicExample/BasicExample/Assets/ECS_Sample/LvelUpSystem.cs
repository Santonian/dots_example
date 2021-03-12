using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class LvelUpSystem : ComponentSystem {
    protected override void OnUpdate() {
        Entities.ForEach((ref LevelComponent levelCompoent) => {
            levelCompoent.level += 1f * Time.DeltaTime;
        });
    }
}
