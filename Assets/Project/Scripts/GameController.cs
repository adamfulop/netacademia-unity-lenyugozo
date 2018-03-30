using UnityEngine;

public class GameController : MonoBehaviour {
    private Car _car;
    private EnemyCarSpawner _enemyCarSpawner;
    private RoadSpawner _roadSpawner;

    private void Awake() {
        _car = FindObjectOfType<Car>();
        _enemyCarSpawner = FindObjectOfType<EnemyCarSpawner>();
        _roadSpawner = FindObjectOfType<RoadSpawner>();
    }

    public void ResetGame() {
        _car.ResetCar();
        _enemyCarSpawner.ResetEnemyCars();
        _roadSpawner.ResetRoad();
    }
}
