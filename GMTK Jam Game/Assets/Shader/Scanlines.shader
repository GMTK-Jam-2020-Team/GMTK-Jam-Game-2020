Shader "Unlit/Scanlines"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
	}
		SubShader
	{
		Tags { "RenderType" = "Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog

			#include "UnityCG.cginc"
			#include "UnityShaderVariables.cginc"
			
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target
			{
				float d = length(i.uv - float2(0.5, 0.5));

				// blur amount
				float blur = 0.0;
				blur = (1.0 + sin(_Time.x * 0.5)) * 0.2;
				blur *= 1.0 + sin(_Time.x * 3.0) * 0;
				blur = pow(blur, 1.0);
				blur *= 0.05;
				// reduce blur towards center
				blur *= d;

				// final color
				float3 col;
				col.r = tex2D(_MainTex, float2(i.uv.x + blur, i.uv.y)).r;
				col.g = tex2D(_MainTex, i.uv).g;
				col.b = tex2D(_MainTex, float2(i.uv.x - blur, i.uv.y)).b;

				// scanline
				float scanline = sin(i.uv.y * 4000.0) * 0.04;
				col -= scanline;

				// vignette
				col *= 1.0 - d * 0.5;

				fixed4 returnCol = fixed4(col, 1.0);
				return returnCol;
			}
			ENDCG
		}
	}
}
