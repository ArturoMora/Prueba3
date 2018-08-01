(function () {
    angular.module("ModuloPrincipal")
        .controller("EmpresasGetCtrl", ["$scope", "EmpresasService", EmpresasGetCtrl]);

    function EmpresasGetCtrl($scope, EmpresasService) {

        $scope.obtenerRegistros = function () {
            EmpresasService.getAll().then(function (res) {
                $scope.lista = res.data;
            }, function (err) {
                console.log("Error:", err);
            });
        }

        $scope.eliminarRegistro = function (id) {
            EmpresasService.delete(id).then(function () {
                $scope.obtenerRegistros();
                alert('Registro eliminado exitosamente');
            }, function () {
                console.log("Error:", err);
            })
        }

        $scope.obtenerRegistros();
    }

})();