using UnityEngine;

/*public class PuzzlePiece : MonoBehaviour
{

    private GameObject puzzle1;
    private GameObject box1;

    void Start()
    {
        puzzle1 = GameObject.FindGameObjectWithTag("puzzle1");
        box1 = GameObject.FindGameObjectWithTag("box1");

        if (puzzle1 != null && box1 != null)
        {
            if (puzzle1.transform.position == box1.transform.position)
            {
                puzzle1.transform.position = box1.transform.position;
            }
        }
    }


    private bool isDragging = false; // Parçanın sürüklendiğini belirten bayrak
    private Vector3 startPosition; // Parçanın başlangıç pozisyonu

    // Fare tıklaması algılandığında çalışan fonksiyon
    void OnMouseDown()
    {
        isDragging = true;
        startPosition = transform.position; // Parçanın başlangıç pozisyonu kaydet
    }

    // Fare bırakıldığında çalışan fonksiyon
    void OnMouseUp()
    {
        isDragging = false;

        // Parçanın doğru konumda olup olmadığını kontrol et
        if (IsInCorrectPosition())
        {
            // Parça doğru konumdaysa yapılacak işlemler



            Debug.Log("Parça doğru konumda!");
        }
        else
        {
            // Parçayı başlangıç pozisyonuna geri götür
            transform.position = startPosition;
        }
    }

    // Her güncelleme adımında çalışan fonksiyon
    void Update()
    {
        if (isDragging)
        {
            // Fare pozisyonunu dünya koordinatlarına dönüştür
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Parçanın z ekseninde aynı konumda kalmasını sağla

            // Parçanın pozisyonunu fareyi takip edecek şekilde güncelle
            transform.position = mousePosition;
        }
    }

    // Parçanın doğru konumda olup olmadığını kontrol eden fonksiyon
    bool IsInCorrectPosition()
    {
        // Parçanın doğru konumda olup olmadığını kontrol etmek için mantık ekle
        // Bu, parçanın diğer parçalara göre pozisyonunu veya bazı referans noktalarını kontrol edebilir
        // Basitlik için, parçanın doğru konumda olduğunu kabul edeceğimiz bir hedef pozisyon belirtelim




        Vector3 targetPosition = new Vector3(0, 0, 0); // Örnek hedef pozisyon
        float threshold = 0.5f; // Doğru konumda kabul edilecek eşik değeri

        if (Vector3.Distance(transform.position, targetPosition) < threshold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
 */