using UnityEngine;

public class SideTile : MonoBehaviour {
    public Side DefaultSide;

    public void MoveToPosition(Side side, float nearX) {
        if (side == DefaultSide) {
            transform.Translate(nearX, 0, 0);
        } else {
            transform.Rotate(Vector3.up, 180);
            transform.Translate(nearX + 5, 0, -20, Space.World);
        }
    }
}
