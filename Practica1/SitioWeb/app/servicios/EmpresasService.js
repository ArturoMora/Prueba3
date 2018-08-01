(function () {
    angular
        .module("ModuloPrincipal")
        .factory("EmpresasService", [
            "$http",
            "HOST",
            EmpresasService
        ]);


    function EmpresasService($http, HOST) {
        var service = {};

        //GetAll
        service.getAll = function () {
            var endpoint = HOST + "Empresas/GetAll";
            return $http.get(endpoint);
        };

        //GetById
        service.getById = function (id) {
            var endpoint = HOST + "Empresas/GetById/"+id;
            return $http.get(endpoint);
        };

        //Create
        service.create = function (empresa) {
            var endpoint = HOST + "Empresas/create";
            return $http.post(endpoint, empresa);
        };

        //Update
        service.update = function (empresa) {
            var endpoint = HOST + "Empresas/update";
            return $http.put(endpoint, empresa);
        };

        //Delete
        service.delete = function (id) {
            var endpoint = HOST + "Empresas/delete/"+id;
            return $http.delete(endpoint);
        };

        return service;
    }
})();