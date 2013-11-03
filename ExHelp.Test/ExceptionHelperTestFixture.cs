using System;
using System.Collections.Generic;
using ExHelp.Exceptions;
using NUnit.Framework;

namespace ExHelp.Test
{
    [TestFixture]
    public class ExceptionHelperTestFixture
    {
        [Test]
        public void CheckForNullObjectNoException()
        {
            ExceptionHelper.CheckForNull(new TestHelper());
        }

        [Test]
        public void CheckForNullNullObjectThrowsNullEx()
        {
            Assert.Throws<ArgumentNullException>(() => ExceptionHelper.CheckForNull(null));
        }

        [Test]
        public void CheckForEmptyListPopulatedListNoException()
        {
            ExceptionHelper.CheckForEmptyList(new List<TestHelper>() { new TestHelper() });
        }

        [Test]
        public void CheckForEmptyListThrowsEmptyListEx()
        {
            Assert.Throws<EmptyCollectionException>(() => ExceptionHelper.CheckForEmptyList(new List<TestHelper>()));
        }

        [Test]
        public void CheckForEmptyNoException()
        {
            ExceptionHelper.CheckForEmpty(new Dictionary<TestHelper, int>() { { new TestHelper(), 1 } });
        }

        [Test]
        public void CheckForEmptyThrowsEmptyListEx()
        {
            Assert.Throws<EmptyCollectionException>(() => ExceptionHelper.CheckForEmpty(new Dictionary<TestHelper, int>()));
        }

        [Test]
        public void CheckContainsKeyDoesNotContainKeyThrowsEx()
        {
            Assert.Throws<KeyNotFoundException>(() => ExceptionHelper.CheckContainsKey(new Dictionary<int, int>() { { 1, 1 } }, 2));
        }

        [Test]
        public void CheckContainsKeyContainsKeyNoException()
        {
            ExceptionHelper.CheckContainsKey(new Dictionary<int, int>() { { 1, 1 } }, 1);
        }

        private class TestHelper
        {

        }
    }
}
