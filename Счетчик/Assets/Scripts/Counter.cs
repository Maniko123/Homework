using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCounter;

    private float _timeDelay = 0.5f;
    private Coroutine _increasingCounter;
    private WaitForSeconds _expectation;
    private int _number;

    private void Start()
    {
        _number = 0;
        _textCounter.text = _number.ToString();
        _expectation = new WaitForSeconds(_timeDelay);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_increasingCounter != null)
            {
                StopCoroutine(_increasingCounter);
                _increasingCounter = null;
            }
            else
            {
                _increasingCounter = StartCoroutine(CountUp());
            }
        }
    }

    private IEnumerator CountUp()
    {
        while (true)
        {
            _number++;
            _textCounter.text = _number.ToString();
            yield return _expectation;
        }
    }
}
