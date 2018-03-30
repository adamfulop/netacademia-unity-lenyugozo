using UnityEngine;

public class EnemyCarMove : MonoBehaviour {
    public float MinimumSpeed;
    public float MaximumSpeed;

    private float _speed;
    
    private static readonly Vector3 ForwardDirection = new Vector3(0, 0, 1);

    private void Start() {
        _speed = Random.Range(MinimumSpeed, MaximumSpeed);
    }

    private void Update() {
        transform.Translate(ForwardDirection * _speed * Time.deltaTime);
    }
}
