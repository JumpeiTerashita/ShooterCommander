using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace gami
{
    public　class CursolFacePlayer : MonoBehaviour
    {
        // 向かせる先にいるターゲット情報を保持
        [SerializeField]
        public GameObject lookAtTarget;
        // 非アクティブの際に外部からアクセスするための変数
        private static GameObject arrow;

        private const float LENGTH = 2;
        private void Start()
        {
            // 自信を保持
            arrow = this.gameObject;
        }
        private void Update()
        {
            SetCursorRotation();
            SetCursorPos();
        }
        // カーソルの位置調整
        private void SetCursorPos()
        {
            this.transform.position =
                new Vector3(
                    Mathf.Cos((this.transform.parent.eulerAngles.y + 90) * Mathf.Deg2Rad) * LENGTH,
                    Mathf.Sin((this.transform.parent.eulerAngles.x) * Mathf.Deg2Rad) * LENGTH,
                    Mathf.Sin((this.transform.parent.eulerAngles.y + 90) * Mathf.Deg2Rad) * LENGTH);
        }
        // カーソルの回転値を調整
        private void SetCursorRotation()
        {
            // Playerの位置へ向く
            this.transform.LookAt(lookAtTarget.transform);
        }

        public static void ChangeActiveIsTrue()
        {
            arrow.gameObject.SetActive(true);
        }
        public static void ChangeActiveIsFalse()
        {
            arrow.gameObject.SetActive(false);
        }
    }
}