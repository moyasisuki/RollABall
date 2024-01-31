using UnityEngine;

public class GyroTracker : MonoBehaviour
{
    // �W���C���X�R�[�v�N���X�̎Q�Ƃ��L���b�V��
    public Gyroscope gyro;

    // �C�x���g���g���K�[���郁�\�b�h
    public void OnEnable()
    {
        // �f�o�C�X���W���C�����T�|�[�g���Ă��邩�m�F
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    protected void OnGUI()
    {
        if (gyro == null)
        {
            return;
        }

        GUILayout.Label("input.gyro.attitude: " + gyro.attitude);
        GUILayout.Label("input.gyro.userAcceleration: " +
        gyro.userAcceleration);
    }
}
