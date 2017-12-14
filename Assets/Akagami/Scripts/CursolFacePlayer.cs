using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace gami
{
    public class CursolFacePlayer : MonoBehaviour
    {
        [SerializeField]
        public GameObject arrow;

        //メインカメラに付いているタグ名
        private const string MAIN_CAMERA_TAG_NAME = "MainCamera";

        //カメラに表示されているか
        private bool _isRendered = false;
        //private void Start()
        //{
            
        //}
        private void Update()
        {
            // 画面内フラグが立っていたら
            if (_isRendered)
            {
                // カーソルを表示
                arrow.SetActive(false);
            }
            else
            {
                // カーソル非表示
                arrow.SetActive(true);
            }
            // フラグは常にfalseに戻す
            _isRendered = false;
            // カーソルが表示されていたら
            if (arrow.activeInHierarchy == true)
            {
                // 位置を調整
                SetCursorPos();
            }
        }
        //カメラに映ってる間に呼ばれる
        private void OnWillRenderObject()
        {
            //メインカメラに映った時だけ_isRenderedを有効に
            if (Camera.current.tag == MAIN_CAMERA_TAG_NAME)
            {
                // 画面内フラグを立てる
                _isRendered = true;
            }

        }
        // カーソル位置、角度をプレイヤーの方向へ移動させる
        private void SetCursorPos()
        {
            //float look = Mathf.Atan2(
            //    arrow.transform.position.z - this.transform.position.z,
            //    arrow.transform.position.x - this.transform.position.x);

            //arrow.transform.LookAt(this.transform);
            //arrow.transform.
        }
    }
}