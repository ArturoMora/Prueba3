(function () {
    angular.module("ModuloPrincipal")
        .controller("EmpresasAddCtrl", ["$scope", "$state", "EmpresasService", EmpresasAddCtrl]);

    function EmpresasAddCtrl($scope, $state, EmpresasService) {
        $scope.empresa = {};

        $scope.guardar = function () {
            if ($scope.formularioAgregar.$invalid) {
                alert("Llene todos los campos requeridos");
                return false;
            }

            $scope.empresa.fechaRegistro = new Date();
            //llamada al servicio para crear una empresa
            EmpresasService.create($scope.empresa).then(function (res) {
                alert(res.data);
                $scope.regresar();
            }, function (err) {
                console.log("Error:", err);
            });
        }

        $scope.regresar = function () {
            $state.go("EmpresasGet");
        }
        
    }

})();