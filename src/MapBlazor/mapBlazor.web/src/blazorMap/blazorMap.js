		var map;
		import * as mapboxgl from 'mapbox-gl/dist/mapbox-gl'
		

			export function init(ref) {
				
				mapboxgl.accessToken = 'pk.eyJ1IjoidGVyZW50ZXYiLCJhIjoiY2sycDN1Z21zMDBheTNrbzZ2aG42aWUyMiJ9._2hucdk7L6jhzEHE6LGv9A';
				map = new mapboxgl.Map({
				container: 'map',
				style: 'mapbox://styles/terentev/ck63al89d0grl1ip8vr3ulkgu',
				center: [34.047, 63.779],
				zoom: 5.6
			});
		}
