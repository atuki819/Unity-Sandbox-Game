using UnityEngine;
using UnityEngine.UI;

public class KeyInputDisplay : MonoBehaviour
{
    public Text inputText;  // UIのTextオブジェクトをアサインするためのフィールド

    void Update()
    {
        // キー入力をチェックして、対応するメッセージを表示
        if (Input.GetKey(KeyCode.W))
        {
            inputText.text = "Key Input: W";
        }
        else if (Input.GetKey(KeyCode.A))
        {
            inputText.text = "Key Input: A";
        }
        else if (Input.GetKey(KeyCode.S))
        {
            inputText.text = "Key Input: S";
        }
        else if (Input.GetKey(KeyCode.D))
        {
            inputText.text = "Key Input: D";
        }
        else
        {
            inputText.text = "Key Input: None";
        }
    }
}
