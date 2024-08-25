using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // プレイヤーのTransformをアサイン
    public Vector3 offset;    // カメラとプレイヤーの距離

    void Start()
    {
        // オフセットが未設定の場合、カメラの現在位置とプレイヤー位置との差を初期設定
        if (offset == Vector3.zero)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        // プレイヤーの位置にオフセットを加えた位置にカメラを設定
        transform.position = player.position + offset;
    }
}
