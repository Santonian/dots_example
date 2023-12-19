using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public partial struct CubeComponent : IComponentData{
    public float3 moveDirection;
    public float moveSpeed;
}
