using UnityEngine;
using UnityEngine.UI;

public class KeyInputDisplay : MonoBehaviour
{
    public Text inputText;  // UI��Text�I�u�W�F�N�g���A�T�C�����邽�߂̃t�B�[���h

    void Update()
    {
        // �L�[���͂��`�F�b�N���āA�Ή����郁�b�Z�[�W��\��
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
