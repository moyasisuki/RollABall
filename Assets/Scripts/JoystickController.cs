using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler
{
	// ���S����̍ő勗��
	public float maxDistance;

	// �N���b�N�����o�I�ɕ\������
	public Transform joystickHandle;

	// Vector2�������Ɏ��UnityEvent���쐬
	[Serializable]
	public class Vector2UnityEvent : UnityEvent<Vector2> { }

	// �W���C�X�e�B�b�N�̒l��XY��-1�`1�V�X�e���ň����Ɏ��C�x���g
	public Vector2UnityEvent JoystickOutput;

	// �w����ʏ�Ńh���b�O����邽�тɌĂяo�����֐�
	public void OnDrag(PointerEventData eventData)
	{

	}
}

