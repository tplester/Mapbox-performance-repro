using DG.Tweening;
using Mapbox.Unity.Map;
using System.Collections;
using UnityEngine;
using static UnityEditor.PlayerSettings;

namespace Assets
{
	public class ZoomManager : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		float zoomOutLevel = 4;

		[SerializeField]
		float zoomInLevel = 12;

		public void ZoomIn()
		{
			DOTween.To(() => _map.Zoom, x => _map.UpdateMap(x), zoomInLevel, 3f);
		}

		public void ZoomOut()
		{
			DOTween.To(() => _map.Zoom, x => _map.UpdateMap(x), zoomOutLevel, 3f);
		}
	}
}