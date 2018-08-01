(function () {
    angular.module("ModuloPrincipal")
        .controller("EmpresasEditCtrl", ["$scope", "$state", "$stateParams", "EmpresasService", EmpresasEditCtrl]);

    function EmpresasEditCtrl($scope, $state, $stateParams, EmpresasService) {
        
        //Obtiene el registro de una empresa
        EmpresasService.getById($stateParams.id).then(function (res) {
            $scope.empresa = res.data;
        }, function (err) {
            console.log("Error:", err);
        });



        $scope.actualizar = function () {
            if ($scope.formularioEditar.$invalid) {
                alert("Llene todos los campos requeridos");
                return false;
            }

            $scope.empresa.fechaRegistro = new Date();

            //llamada al servicio para actualizar una empresa
            EmpresasService.update($scope.empresa).then(function (res) {
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