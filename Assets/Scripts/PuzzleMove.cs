using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    // Parçanın doğru konumu
    public Vector3 dogruKonum;

    // Parçanın yerleştirilmesi gereken konum
    //public Vector3 dogruKonumParca1 = new Vector3(8f, 0f, 0f);


    bool surukleniyor = false;
    public Vector3 baslangicPozisyonu1 = new Vector3(7f, 0f, 0f);
    float zKonumu;

    void OnMouseDown()
    {
        surukleniyor = true;
        baslangicPozisyonu1 = transform.position;
        zKonumu = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    }

    void OnMouseDrag()
    {
        if (surukleniyor)
        {
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zKonumu);
            Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = new Vector3(objPos.x, objPos.y, baslangicPozisyonu1.z);
        }
    }

    void OnMouseUp()
    {
        surukleniyor = false;

        float mesafe = Vector3.Distance(transform.position, dogruKonum);

        // Parça, doğru konumda bırakıldıysa
        if (mesafe <= 0.5f)
        {
            // Parçayı doğru konumun üzerine yerleştir
            transform.position = dogruKonum;
        }
        else
        {
            // Parçayı başlangıç konumuna geri götür
            transform.position = baslangicPozisyonu1;
        }
    }
}
