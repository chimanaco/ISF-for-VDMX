/*{
	"DESCRIPTION": "2/30 Panda",
	"CREDIT": "by chimanaco",
	"CATEGORIES": [
		"Generators"
	],
	"INPUTS": [
		{
			"NAME": "cycles",
			"TYPE": "float",
			"DEFAULT": 2.0,
			"MIN": 0.0,
			"MAX": 1.0
		},
		{
			"NAME": "frontColor",
			"TYPE": "color",
			"DEFAULT": [
				1.0,
				1.0,
				1.0,
				1.0
			]
		}
	]
}*/

float plasma(vec2 p)
{
  p *= 20.0;
  return (sin(p.x) * cos(cycles * 5.) + 0.25) + (sin(p.y) * cos(cycles * 2.) + 0.25+sin(length(p)*2.0+cycles*3.0));
}

void main()
{
	// frontColor
	vec4 fc = vec4(0,0,0,0);
	fc = frontColor;
	float fcx = fc.x;
	float fcy = fc.y;
	float fcz = fc.z;
	float fca = fc.a;

	vec2 p = vv_FragNormCoord;
	p = p - 0.5;

	vec4 color = vec4(plasma(p));
	float cx = color.x;
	float cy = color.y;
	float cz = color.z;

	gl_FragColor = vec4(min(fcx,cx),min(fcy,cy),min(fcz,cz),fca);
}
