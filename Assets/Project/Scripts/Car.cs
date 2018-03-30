using UnityEngine;

public class Car : MonoBehaviour {
	private Quaternion _startOrientation;
	private Vector3 _startPosition;

	private void Awake() {
		_startOrientation = transform.rotation;
		_startPosition = transform.position;
	}

	public void ResetCar() {
		transform.rotation = _startOrientation;
		transform.position = _startPosition;
	}
}
