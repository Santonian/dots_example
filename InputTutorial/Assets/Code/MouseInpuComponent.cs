using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;

public partial struct MouseInpuComponent : IComponentData
{
    public Vector2 mousePos;
    public bool leftMouseClick;
    public bool rightMouseClick;
}
