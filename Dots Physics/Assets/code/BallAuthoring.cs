using Unity.Entities;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BallAuthoring : MonoBehaviour
{
    public float moveSpeed;
    
    public class BallAuthoringBaker : Baker<BallAuthoring>{

        public override void Bake(BallAuthoring authoring){
            Entity entity = GetEntity(TransformUsageFlags.None);
            AddComponent(entity, new BallComponent{
                moveSpeed = authoring.moveSpeed 
            });
        }

    }
}
