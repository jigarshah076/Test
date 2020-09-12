var app = angular.module("main", []);

app.factory('DataService', function () {
    var DataList = [];
    
    var getData = function () {
        return DataList;
    };

    var addData = function (newObj) {
        DataList.push(newObj);
    };

    return {
        getData: getData,
        addData: addData
    };

});

app.controller("indexController", function ($scope, $rootScope, $http, DataService) {
    
    $scope.init = function () {
        getData();
    }
    $scope.init();

    $scope.ViewData = function (arg) {
        DataService.addData(arg);
        alert("value set");
    }

    function getData() {
        var url = 'https://localhost:44398/api/movie/GetAllMovieList';

        $http.get(url).
            success(function (data, status, headers, config) {
                $scope.MovieList = data;
                alert("Successfully Loaded Movie List..");
            }).
            error(function (data, status, headers, config) {
                //log error
            });

    }
});

app.controller("viewdetailsController", function ($scope, $rootScope, $http, DataService) {

    $scope.init = function () {
        $scope.MovieData = DataService.getData();
    }
    $scope.init();

    
});

