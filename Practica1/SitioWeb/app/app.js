(function () {
    "use strict";

    angular.module("ModuloPrincipal", ['ui.router'])
        .constant('HOST', 'http://localhost:1520/api/')
           .config(['$stateProvider', '$urlRouterProvider', RouterProvider]);

    function RouterProvider($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise("/listadoEmpresas");
        
        $stateProvider
            .state("EmpresasGet", {
                url: "/listadoEmpresas",
                templateUrl: "app/empresas/EmpresasGet.html",
                controller: "EmpresasGetCtrl"
            })
            .state("EmpresasAdd", {
                url: "/agregarEmpresa",
                templateUrl: "app/empresas/EmpresasAdd.html",
                controller: "EmpresasAddCtrl"
            })
            .state("EmpresasEdit", {
                url: "/editarEmpresa/:id",
                templateUrl: "app/empresas/EmpresasEdit.html",
                controller: "EmpresasEditCtrl"
            })
    };

}());