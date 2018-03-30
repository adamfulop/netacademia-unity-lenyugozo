using UnityEngine;

public class CarMove : MonoBehaviour {
	public Joystick Joystick;

	public float Accelleration;
	public float Speed;
	public float TurnSpeed;

	private static readonly Vector3 ForwardDirection = new Vector3(0, 0, 1);

	private void Update() {
		var inputVertical = Joystick.Vertical;
		var inputHorizontal = Joystick.Horizontal;
		
		transform.Rotate(0, inputHorizontal * TurnSpeed * Time.deltaTime, 0);
		transform.Translate(ForwardDirection * (Speed + inputVertical * Accelleration) * Time.deltaTime, Space.Self);
	}
}
