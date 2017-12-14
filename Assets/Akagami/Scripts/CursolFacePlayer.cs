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

        [SerializeField]
        public Camera mainCamera;

        // メインカメラに付いているタグ名
        private const string MAIN_CAMERA_TAG_NAME = "MainCamera";

        // カメラに表示されているか
        private bool _isRendered = false;

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
                SetCursorRotation();
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
        // カーソルの回転値を調整
        private void SetCursorRotation()
        {
            // Playerの位置へ向く
            arrow.transform.LookAt(this.transform);
        }
    }
}