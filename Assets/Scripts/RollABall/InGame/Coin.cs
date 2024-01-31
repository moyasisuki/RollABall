using System.Collections;
using UnityEngine;
public class Coin : MonoBehaviour
{
    private float bonusTime = 2f;
    private float disappearTime = 5f;
    private int bonusScoreValue = 20;
    private bool isBonus = true;
    private int scoreValue = 10;
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // �����܂ł̓{�[�i�X�^�C����2�b�҂�
        yield return new WaitForSeconds(bonusTime);
        isBonus = false;
        // �����鎞�Ԃ�5�b�Ȃ̂ŁA�{�[�i�X�^�C����2�b�����3�b�҂�
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (isBonus)
            {
                Scoremanager.ScoreCount += bonusScoreValue;
            }
            else
            {
                Scoremanager.ScoreCount += scoreValue;
            }
            Destroy(gameObject);
        }
    }
}

