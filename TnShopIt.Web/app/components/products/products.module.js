/// <reference path="D:\sofwear\BaiTapC#\TnShopIT\TnShopIt.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('tnitshop.product', ['tnitshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('products_add', {
            url: "/products_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        });
    }
})();