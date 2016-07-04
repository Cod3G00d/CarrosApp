(function () {
	'use strict';

	/**
	 * @ngdoc function
	 * @name app.test:fabricantesTest
	 * @description
	 * # fabricantesTest
	 * Test of the app
	 */

	describe('fabricantes test', function () {
		var controller = null, $scope = null;

		beforeEach(function () {
			module('carscollectors');
		});

		beforeEach(inject(function ($controller, $rootScope) {
			$scope = $rootScope.$new();
			controller = $controller('FabricantesCtrl', {
				$scope: $scope
			});
		}));

		it('Should controller must be defined', function () {
			expect(controller).toBeDefined();
		});

	});
})();
