using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // �v���C���[��Transform���A�T�C��
    public Vector3 offset;    // �J�����ƃv���C���[�̋���

    void Start()
    {
        // �I�t�Z�b�g�����ݒ�̏ꍇ�A�J�����̌��݈ʒu�ƃv���C���[�ʒu�Ƃ̍��������ݒ�
        if (offset == Vector3.zero)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        // �v���C���[�̈ʒu�ɃI�t�Z�b�g���������ʒu�ɃJ������ݒ�
        transform.position = player.position + offset;
    }
}
