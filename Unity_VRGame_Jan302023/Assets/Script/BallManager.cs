using UnityEngine;

public class BallManager : MonoBehaviour
{
    [Header("碰到畫布後的圖示或顏料")]
    public GameObject pictureObject;
    [Header("碰到畫布後的特效")]
    public GameObject effectObject;
    [Header("碰撞音效")]
    public AudioClip soundHit;
    [Header("圖片的角度")]
    public Vector3 pictureAngle;

    private void OnCollisionEnter(Collision collision)
    {
        // print(collision.gameObject.name);

        // 如果 碰到物件的名稱 等於 畫布
        // 就 生成 圖片與特效
        if (collision.gameObject.name == "畫布")
        {
            Instantiate(effectObject, transform.position, transform.rotation);

            // Quaternion.Euler(角度)
            Instantiate(pictureObject, transform.position, Quaternion.Euler(pictureAngle));

            // 刪除(此物件)
            Destroy(gameObject);
        }
    }
}