using Lean.Pool;
using UnityEngine;

public class EnemyCar : MonoBehaviour {
    private Car _car;
    private GameController _gameController;
    
    private const float DestroyThreshold = -10;

    private void Awake() {
        _car = FindObjectOfType<Car>();
        _gameController = FindObjectOfType<GameController>();
    }

    private void Update() {
        if (transform.position.x - _car.transform.position.x < DestroyThreshold) {
            LeanPool.Despawn(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Car")) {
            _gameController.ResetGame();
        }
    }
}