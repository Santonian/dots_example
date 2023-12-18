using Unity.Entities;
using Unity.Mathematics;
using UnityEngine.InputSystem;
using UnityEngine;

public partial class InputSystem : SystemBase
{
    private Controls controls;

    protected override void OnCreate() {
        if(!SystemAPI.TryGetSingleton<MouseInpuComponent>(out MouseInpuComponent input)) {
            EntityManager.CreateEntity(typeof(MouseInpuComponent));
        }

        controls = new Controls();
        controls.Enable();
    }

    protected override void OnUpdate() {
        SystemAPI.SetSingleton(new MouseInpuComponent {
            mousePos = controls.ActionMap.MousePosition.ReadValue<Vector2>(),
            leftMouseClick = controls.ActionMap.MouseButtonLeft.ReadValue<float>() == 1 ? true : false,
            rightMouseClick = controls.ActionMap.MouseButtonRight.ReadValue<float>() == 1 ? true : false
        });
    }
}
