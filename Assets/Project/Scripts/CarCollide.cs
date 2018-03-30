using UnityEngine;

public class CarCollide : MonoBehaviour {
    private GameController _gameController;

    private void Awake() {
        _gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Car")) {
            _gameController.ResetGame();
        }
    }
}