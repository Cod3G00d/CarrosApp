(function() {
	'use strict';

	/**
	* @ngdoc function
	* @name app.controller:fabricantesCtrl
	* @description
	* # fabricantesCtrl
	* Controller of the app
	*/

  	angular
		.module('fabricantes')
		.controller('FabricantesCtrl', Fabricantes);

  	Fabricantes.$inject = ['FabricantesService'];

		/*
		* recommend
		* Using function declarations
		* and bindable members up top.
		*/

  	function Fabricantes(FabricantesService) {
			/*jshint validthis: true */
			var vm = this;
			FabricantesService.query().$promise.then(function (data) { vm.teste = data; }, function (error) { console.log(error); });
            
		}

})();
