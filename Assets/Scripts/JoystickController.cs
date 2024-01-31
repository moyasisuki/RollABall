using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler
{
	// 中心からの最大距離
	public float maxDistance;

	// クリックを視覚的に表現する
	public Transform joystickHandle;

	// Vector2を引数に取るUnityEventを作成
	[Serializable]
	public class Vector2UnityEvent : UnityEvent<Vector2> { }

	// ジョイスティックの値をXYと-1～1システムで引数に取るイベント
	public Vector2UnityEvent JoystickOutput;

	// 指が画面上でドラッグされるたびに呼び出される関数
	public void OnDrag(PointerEventData eventData)
	{

	}
}

