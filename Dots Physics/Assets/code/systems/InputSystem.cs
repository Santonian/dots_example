using UnityEngine;
using Unity.Entities;

public partial class InputSystem : SystemBase
{
    private InputControls controls;

    protected override void OnCreate() {
        if(!SystemAPI.TryGetSingleton<InputComponent>(out InputComponent input)) {
            EntityManager.CreateEntity(typeof(InputComponent));
        }

        controls = new InputControls();
        controls.Enable();
    }

    protected override void OnUpdate() {
        SystemAPI.SetSingleton(new InputComponent {
            mousePos = controls.ActionMap.MousePosition.ReadValue<Vector2>(),
            movement = controls.ActionMap.Movement.ReadValue<Vector2>(),
            pressingLmb = controls.ActionMap.LeftMouseButton.ReadValue<float>() == 1 ? true : false
        });
    }
}