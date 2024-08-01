using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public enum Direction
{
    LEFT = -1,
    RIGHT = 1
}
public class Player : MonoBehaviour
{
    [SerializeField] GameObject heartObject;
    [SerializeField] GameObject aim;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] private int currentHeart = 2;
    [SerializeField] private Text currentHeartText;
    private bool isAiming;
    private Vector3 mousePos = Vector3.down;
    private Direction currentDirection = Direction.RIGHT;
    private EventSystem eventSys;
    private void Start()
    {
        lineRenderer.gameObject.SetActive(false);
        eventSys = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        SetHeartText();
    }
    // Update is called once per frame
    void Update()
    {
        if(currentHeart ==0){
            return;
        }
        if(Time.timeScale==0){
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(EventSystem.current.IsPointerOverGameObject()){
                return;
            };
            isAiming = true;
            lineRenderer.gameObject.SetActive(true);
            lineRenderer.SetPosition(0, aim.transform.position);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if(EventSystem.current.IsPointerOverGameObject()){
                return;
            };
            lineRenderer.gameObject.SetActive(false);
            isAiming = false;
            GameObject temp = Instantiate(heartObject, aim.transform.position, Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().AddForce((lineRenderer.GetPosition(1) - lineRenderer.GetPosition(0)) * 100);
            currentHeart--;
            SetHeartText();
        }
        if (isAiming)
        {
            if (mousePos.x > transform.position.x && currentDirection == Direction.LEFT)
            {
                RotateY(Direction.RIGHT);
            }
            else if (mousePos.x <= transform.position.x && currentDirection == Direction.RIGHT)
            {
                RotateY(Direction.LEFT);
            }
            SetLineRenderPos1();
        }
    }
    private void SetHeartText(){
        currentHeartText.text = "x"+ currentHeart;
    }
    private void RotateY(Direction direction)
    {
        transform.localScale = new Vector3((int)direction, 1, 1);
        currentDirection = direction;
        lineRenderer.SetPosition(0, aim.transform.position);
    }
    private void SetLineRenderPos1()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        lineRenderer.SetPosition(1, mousePos);
    }
    private bool IsPointerOverUIElement(List<RaycastResult> eventSystemRaysastResults)
    {
        for (int index = 0; index < eventSystemRaysastResults.Count; index++)
        {
            RaycastResult curRaysastResult = eventSystemRaysastResults[index];
            if (curRaysastResult.gameObject.layer == 5 && curRaysastResult.gameObject == this.gameObject)
                return true;
        }
        return false;
    }


    //Gets all event system raycast results of current mouse or touch position.
    static List<RaycastResult> GetEventSystemRaycastResults()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;
        List<RaycastResult> raysastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raysastResults);
        return raysastResults;
    }
}
