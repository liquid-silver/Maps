#pragma checksum "C:\Users\pvkon\source\repos\MapsAPI\MapsAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34286234b4349a9747b0f4fcc056f2b6136a8c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MapsAPI.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace MapsAPI.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pvkon\source\repos\MapsAPI\MapsAPI\Views\_ViewImports.cshtml"
using MapsAPI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34286234b4349a9747b0f4fcc056f2b6136a8c50", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178761fd83b16b5a34aa77338f756593dcac7f0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mapStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pvkon\source\repos\MapsAPI\MapsAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34286234b4349a9747b0f4fcc056f2b6136a8c503789", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h3>Расчет стоимости поездки</h3>
<div id=""map"" class=""map""></div>
<script src=""https://api-maps.yandex.ru/2.1/?apikey=8730ee08-a530-460e-b7e9-bbacfb567b40&lang=ru_RU"" type=""text/javascript""></script>

<script type=""text/javascript"">
    // Функция ymaps.ready() будет вызвана, когда загрузятся все компоненты API, а также когда будет готово DOM-дерево.
    ymaps.ready(init);
    function init() {
        // Стоимость за километр.
        const CITY_TARIFF = 1000.00,
            COUNTRYSIDE_TARIFF = 100.00;

        // Создание карты.
        var map = new ymaps.Map(""map"", {
            // Координаты центра карты: «широта, долгота».
            center: [59.95, 30.35],
            // Уровень масштабирования. Допустимые значения: от 0 (весь мир) до 19.
            zoom: 11,
            controls: ['routePanelControl']
        });

        // Создаем прямоугольник с помощью вспомогательного класса.
        var myRectangle = new ymaps.Rectangle([
            // Задаем координаты диагональных у");
            WriteLiteral(@"глов прямоугольника.
            [60.1, 30.555],
            [59.8, 29.65]
        ], {
            //Свойства
            hintContent: 'Меня перетаскивать нельзя!',
            balloonContent: 'Прямоугольник 1'
        }, {
            // Опции.
            // Цвет и прозрачность заливки.
            fillColor: '#7df9ff33',
            // Дополнительная прозрачность заливки..
            // Итоговая прозрачность будет не #33(0.2), а 0.1(0.2*0.5).
            fillOpacity: 0.5,
            // Цвет обводки.
            strokeColor: '#0000FF',
            // Прозрачность обводки.
            strokeOpacity: 0.5,
            // Ширина линии.
            strokeWidth: 2,
            // Радиус скругления углов.
            // Данная опция принимается только прямоугольником.
            borderRadius: 200,
            visible: false
        });

        map.geoObjects.add(myRectangle);

        ////маркер
        //let placemark = new ymaps.Placemark([59.940669, 30.491097], {}, { //
        //    iconLayout: 'def");
            WriteLiteral(@"ault#image',
        //    iconImageHref: 'https://cdn-icons-png.flaticon.com/512/8758/8758493.png',
        //    iconImageSize: [40, 40],
        //    iconImageOffset: [-19, -44]
        //})
        //map.geoObjects.add(placemark);

        map.controls.remove('geolocationControl'); // удаляем геолокацию
        map.controls.remove('searchControl'); // удаляем поиск
        map.controls.remove('trafficControl'); // удаляем контроль трафика
        map.controls.remove('typeSelector'); // удаляем тип
        map.controls.remove('fullscreenControl'); // удаляем кнопку перехода в полноэкранный режим
        //map.controls.remove('zoomControl'); // удаляем контрол зуммирования
        map.controls.remove('rulerControl'); // удаляем контрол правил
        //map.behaviors.disable(['scrollZoom']); // отключаем скролл карты (опционально)

        let control = map.controls.get('routePanelControl');

        control.routePanel.state.set({
            type: 'auto',
            fromEnabled: true,");
            WriteLiteral(@"
            toEnabled: true
        })

        control.routePanel.options.set({
            reverseGeocoding: true,
            types: { auto: true }
        })

        // Получим ссылку на маршрут.
        control.routePanel.getRouteAsync().then(function (route) {

            // Зададим максимально допустимое число маршрутов, возвращаемых мультимаршрутизатором.
            route.model.setParams({ results: 1 }, true);

            // Повесим обработчик на событие построения маршрута.
            route.model.events.add('requestsuccess', function () {

                var activeRoute = route.getActiveRoute();
                if (activeRoute) {
                    // Получим протяженность и длительность маршрута.
                    let length = activeRoute.properties.get(""distance""),
                        text = String(activeRoute.properties.get(""duration"").text),
                        time = getTime(text),

                        // Вычислим стоимость доставки.
               ");
            WriteLiteral(@"         price = calculateOut(Math.round(length.value / 1000));

                    let from = control.routePanel.state.get(""from""),
                        to = control.routePanel.state.get('to');
                    console.log(from);
                    console.log(to);
                    let coords = '['+from[0] + ', ' + from[1]+']';
                    console.log(coords);
                    if (myRectangle.geometry.contains(from) && myRectangle.geometry.contains(to)) {
                        price = calculateIn(time);
                    }
                    // Создадим макет содержимого балуна маршрута.
                    balloonContentLayout = ymaps.templateLayoutFactory.createClass(
                        '<span>Расстояние: ' + length.text + '.</span><br/>' +
                        '<span>Время: ' + activeRoute.properties.get(""duration"").text + '</span><br/>' +
                        '<span style=""font-weight: bold; font-style: italic"">Стоимость доставки: ' + price + ' р.</spa");
            WriteLiteral(@"n>');
                    // Зададим этот макет для содержимого балуна.
                    route.options.set('routeBalloonContentLayout', balloonContentLayout);
                    // Откроем балун.
                    activeRoute.balloon.open();
                }
            });
        });

        // Функции, вычисляющие стоимость доставки.
        function calculateIn(routeDuration) {
            return Math.round((routeDuration * CITY_TARIFF/60));
        }
        function calculateOut(routeLength) {
            return routeLength * COUNTRYSIDE_TARIFF;
        }
        // Функция, вычисляющая время.
        function getTime(time) {
            let result = 0;
            let bufer = time;
            //дни
            if (bufer.indexOf(""д"") > -1) {
                result += bufer.substring(0, bufer.indexOf(""д"") - 1) * 24 * 60;
                bufer = bufer.substring(bufer.indexOf(""д"") + 4);
            }
            //часы
            if (bufer.indexOf(""ч"") > -1) {
         ");
            WriteLiteral(@"       result += bufer.substring(0, bufer.indexOf(""ч"") - 1) * 60;
                bufer = bufer.substring(bufer.indexOf(""ч"") + 2);
            }
            //минуты
            result += Number(bufer.substring(0, bufer.indexOf(""м"") - 1));
            return result;
        }
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
