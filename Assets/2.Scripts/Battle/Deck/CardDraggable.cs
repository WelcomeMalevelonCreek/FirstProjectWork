using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDraggable : MonoBehaviour//, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    /*
    private Card card;
    private Transform handTf, canvasTf;

    /// <summary>
    /// ī�尡 ����� ����  �ִ���.
    /// </summary>
    public bool isOnDropZone;

    /// <summary>
    /// ������ �巡�װ� �Ǿ�����.
    /// </summary>
    public bool mousePointFollow;
    public bool avoidOverlap;
    private bool mouseOver;//�ߺ����� ����
    private float yPos2BeExtended;//Ȯ��� ī�尡 ������ ���� y ��ǥ.

    
    void Start()
    {
        canvasTf = GameObject.Find("Canvas").GetComponent<Transform>();
        handTf = canvasTf.Find("Hand").GetComponent<Transform>();
        card = GetComponent<Card>();

        //ī���� scale�� �������� ��, �ػ󵵿� ���� ī�尡 ���� Y��ǥ�� ���.
        float cardHalfY = card.transform.GetComponent<RectTransform>().rect.height * (HandManager.Instance.cardMaxSize + 0.5f) / 2f;
        float canvasHalfY = canvasTf.GetComponent<RectTransform>().rect.height / 2f;
        yPos2BeExtended = cardHalfY - canvasHalfY;

        isOnDropZone = mousePointFollow = avoidOverlap = false;
    }

    void Update()
    {
        //ī�尡 �巡�� �Ǿ��� ��, ���콺 �����͸� õõ�� ����ٴϵ��� ȿ���� ��.
        if (mousePointFollow)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 10f);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (HandManager.Instance.endDraw)
        {
            transform.SetParent(canvasTf);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            mousePointFollow = HandManager.Instance.dragCard = avoidOverlap = true;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //ī���� �̵��� OnDrag�� �־����� ���콺 �����͸� õõ�� ���󰡰� �ϸ� ����� �̵��ϱ� ������ �̵��� Update���� ó���Ѵ�. 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (HandManager.Instance.endDraw && mousePointFollow)
        {
            mousePointFollow = false;
            transform.SetParent(handTf);
            transform.SetSiblingIndex(card.order);//������Ű���� ���� ����.
            if (!isOnDropZone)
            {
                ChangeTransform(ObjectControl.RotationAngle(gameObject, card.angle), HandManager.Instance.cardMaxSize, card.targetPos);
                HandManager.Instance.RollBackGapCards(card.order);
                StartCoroutine(Timer(0.1f));
            }
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            HandManager.Instance.dragCard = false;
        }
    }

    //���콺�� �÷����� ī�� ȸ��, Ȯ��
    void OnMouseOver()
    {
        if (!isOnDropZone && card.isDraggable && !mousePointFollow && HandManager.Instance.endDraw && !HandManager.Instance.dragCard && !mouseOver && !avoidOverlap)
        {
            mouseOver = true;
            transform.SetAsLastSibling();
            ChangeTransform(ObjectControl.RotationAngle(gameObject, 0f), HandManager.Instance.cardMaxSize + 0.5f, new Vector3(transform.localPosition.x, yPos2BeExtended, -1f));
            HandManager.Instance.ExpandGapSelectedCard(card.order);
        }
    }

    //���콺�� ġ������ ī�� ȸ��, ���
    void OnMouseExit()
    {
        if (!isOnDropZone && card.isDraggable && !mousePointFollow && HandManager.Instance.endDraw && !HandManager.Instance.dragCard && !avoidOverlap)
        {
            transform.SetSiblingIndex(GetComponent<Card>().order);
            ChangeTransform(ObjectControl.RotationAngle(gameObject, card.angle), HandManager.Instance.cardMaxSize, card.targetPos);
            HandManager.Instance.RollBackGapCards(card.order);
        }
        mouseOver = false;
    }

    //ī���� ũ��, ȸ��, �̵��� ��� ����.
    void ChangeTransform(float varAngle, float varScale, Vector3 varPos)
    {
        transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + varAngle);
        transform.localScale = new Vector3(varScale, varScale, 0f);
        transform.localPosition = varPos;
    }

    //drag�� ����������, OnMouseOver�� OnMouseExit�� ����Ǵ°� �������� Ÿ�̸Ӹ� �߰�.
    IEnumerator Timer(float time)
    {
        float curTime = 0f;
        while (curTime < time)
        {
            curTime += Time.deltaTime;
            yield return null;
        }
        avoidOverlap = false;
    }
    */
}
