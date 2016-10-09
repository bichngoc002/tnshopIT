/// <reference path="D:\sofwear\BaiTapC#\TnShopIT\TnShopIt.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('tnitshop', ['tnitshop.product', 'tnitshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: '/admin',
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();