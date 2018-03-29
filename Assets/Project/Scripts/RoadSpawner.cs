using Lean.Pool;
using UnityEngine;

public class RoadSpawner : MonoBehaviour {
    public GameObject RoadSegmentPrefab;

    public float RoadSegmentSpawnThreshold;

    private GameObject _car;
    private GameObject _lastRoadSegment;
    
    private void Awake() {
        _car = GameObject.FindGameObjectWithTag("Car");
    }

    private void Start() {
        for (var i = 0; i < 30; i++) {
            SpawnRoadSegment();
        }
    }

    private void Update() {
        if (_lastRoadSegment.transform.position.x - _car.transform.position.x < RoadSegmentSpawnThreshold) {
            SpawnRoadSegment();
        }
    }

    private void SpawnRoadSegment() {
        var position = Vector3.zero;
        if (_lastRoadSegment != null) {
            position = new Vector3(_lastRoadSegment.transform.position.x + 5, 0, 0);
        }

        _lastRoadSegment = LeanPool.Spawn(RoadSegmentPrefab, position, Quaternion.identity, transform);
    }
}
